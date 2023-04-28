using _2_CodeFirstApp.Context;
using _2_CodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace _2_CodeFirstApp
{
    public partial class FrmCourse : Form
    {
        public FrmCourse()
        {
            InitializeComponent();
            btnList_Click(null, new EventArgs());
            cbEducatorFill();
            gbStudentsFill();
            isUpdate = false;
        }
        CourseDbContext db = new CourseDbContext();
        public void gbStudentsFill()
        {
            gbStudents.Controls.Clear();
            int studentCount = db.Students.Count();
            int y = 0, x = 0;
            foreach (var student in db.Students)
            {
                CheckBox check = new CheckBox();
                check.Name = $"check{student.Name}";
                check.Text = $"{student.Name} {student.Surname}";

                y += 25;
                if (y > gbStudents.Size.Height)
                {
                    y = 25;
                    x += 110;
                }
                check.Location = new Point(10 + x, y);
                gbStudents.Controls.Add(check);
            }
        }

        public void cbEducatorFill()
        {
            cbEducator.Items.Clear();
            foreach (var educator in db.Educators)
            {
                cbEducator.Items.Add($"{educator.Name} {educator.Surname}");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Course course;
            if (!isUpdate)
            {
                course = new Course(txtName.Text, dtpStartDate.Value, dtpEndDate.Value);
            }
            else
            {
                course = db.Courses.Find(id);
                course.Name = txtName.Text;
                course.StartDate = dtpStartDate.Value;
                course.EndDate = dtpEndDate.Value;
            }
            string[] array = cbEducator.Text.Split(' ');
            Educator educator = new Educator(array[0], array[1]);
            course.EducatorId = db.Educators.FirstOrDefault(i => i.Name == educator.Name && i.Surname == educator.Surname).Id;

            course.Students.RemoveAll(i=>i.Id>0);
            foreach (var item in gbStudents.Controls)
            {
                if ((item as CheckBox).Checked)
                {
                    array = (item as CheckBox).Text.Split(' ');
                    Student s = new Student(array[0], array[1]);
                    Student student = db.Students.FirstOrDefault(i => i.Name == s.Name && i.Surname == s.Surname);
                    course.Students.Add(student);
                }

            }
            if(!isUpdate)
            {
                db.Courses.Add(course);
                db.SaveChanges();
            }
           else
            {
                db.Entry(course).State = EntityState.Modified;
                db.SaveChanges();
            }
            btnList_Click(sender, e);
            isUpdate = false;
        }


        private void lblEducator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAdd f = new FrmAdd();
            f.Text = "Eğitmen Ekle";
            f.isEducator = true;
            f.Show();
        }

        private void lblStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAdd f = new FrmAdd();
            f.Text = "Öğrenci Ekle";
            f.isEducator = false;
            f.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //eğitmen Id ile
            //  dgv.DataSource = db.Courses.Select(i => new
            //  {
            //      ID = i.Id,
            //      AD = i.Name,
            //      BAŞLANGIÇTARİHİ = i.StartDate,
            //      BİTİŞTARİHİ = i.EndDate,
            //      EGİTMEN = i.EducatorId
            //  }).ToList();


            //Join ile eğitmöen adı ve soyadı kullanımı
            //2.yöntem Linq
            //var query = from c in db.Courses
            //            join t in db.Educators on c.EducatorId equals t.Id
            //            select new
            //            {
            //                ID = c.Id,
            //                AD = c.Name,
            //                BAŞLANGIÇTARİHİ = c.StartDate,
            //                BİTİŞTARİHİ = c.EndDate,
            //                EGİTMEN = t.Name + " "+ t.Surname
            //            };
            //dgv.DataSource =  query.ToList();


            //3.yöntem Lambda
            dgv.DataSource = db.Courses.Join(db.Educators, c => c.EducatorId, t => t.Id, (c, t) => new
            {
                ID = c.Id,
                AD = c.Name,
                BAŞLANGIÇTARİHİ = c.StartDate,
                BİTİŞTARİHİ = c.EndDate,
                EGİTMEN = t.Name + " " + t.Surname
            }).ToList();
        }
        int id;
        private void çıkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = (int)dgv.CurrentRow.Cells[0].Value;
            Course course = db.Courses.FirstOrDefault(i => i.Id == id);
            db.Entry(course).State = EntityState.Deleted;
            db.SaveChanges();
            btnList_Click(sender, e);
        }

        bool isUpdate;
        private void değiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isUpdate = true;
            id = (int)dgv.CurrentRow.Cells[0].Value;
            txtName.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            dtpStartDate.Value = (DateTime)dgv.CurrentRow.Cells[2].Value;
            dtpEndDate.Value = (DateTime)dgv.CurrentRow.Cells[3].Value;

            string[] array = dgv.CurrentRow.Cells[4].Value.ToString().Split(' ');
            Educator educator = new Educator(array[0], array[1]);
            cbEducator.Text = educator.Name + " " + educator.Surname;

            Course course = db.Courses.Find(id);

            GroupboxNull();
            foreach (var control in gbStudents.Controls)
            {
                string name = (control as CheckBox).Name.Remove(0, 5);
                foreach (var item in course.Students)
                {

                    if (name == item.Name)
                    {
                        (control as CheckBox).Checked = true;
                    }

                }
            }
        }

        private void GroupboxNull()
        {
            foreach (var control in gbStudents.Controls)
            {

                (control as CheckBox).Checked = false;
            }
        }
    }
}
