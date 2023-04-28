﻿using _3_Sahibinden.Context;
using _3_Sahibinden.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace _3_Sahibinden
{
	public partial class FrmBrandAndColor : Form
	{
		public FrmBrandAndColor()
		{
			InitializeComponent();
		}
		CarDbContext db = new CarDbContext();
		FrmCar fc;
		private void btnBrand_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["FrmCar"] == null)
				fc = new FrmCar();
			else
				fc = (FrmCar)Application.OpenForms["FrmCar"];

			if (fc.isBrandAdd)
			{
				Brand brand = new Brand(txtBrand.Text);
				Brand test = db.Brands.FirstOrDefault(i => i.Name.ToLower() == brand.Name.ToLower());
				if (test == null)
				{
					if (txtBrand.Text != "")
					{
						db.Brands.Add(brand);
						db.SaveChanges();
					}
					else
					{
						MessageBox.Show("Boş bırakılamaz");
					}

				}
				else
				{
					MessageBox.Show("Böyle bir marka zaten mevcut");
				}
			}
			else
			{
				Brand brand = db.Brands.FirstOrDefault(i => i.Name.ToLower() == fc.brand_name.ToLower());
				brand.Name = txtBrand.Text;
				db.Entry(brand).State = EntityState.Modified;
				db.SaveChanges();
			}
			txtBrand.Text = "";

			fc.cbBrandFill();
		}

		private void btnColor_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["FrmCar"] == null)
				fc = new FrmCar();
			else
				fc = (FrmCar)Application.OpenForms["FrmCar"];

			if (fc.isColorAdd)
			{
				Models.Color color = new Models.Color(txtColor.Text);
				Models.Color test = db.Colors.FirstOrDefault(i => i.Name.ToLower() == color.Name.ToLower());
				if (test == null)
				{
					if (txtColor.Text != "")
					{
						db.Entry(color).State = EntityState.Added;
						db.SaveChanges();
					}
					else
					{
						MessageBox.Show("Boş bırakılamaz");
					}
				}
				else
				{
					MessageBox.Show("Böyle bir renk zaten mevcut");
				}
			}
			else
			{
				Models.Color color = db.Colors.FirstOrDefault(i => i.Name.ToLower() == fc.color_name.ToLower());
				color.Name = txtBrand.Text;
				db.Entry(color).State = EntityState.Modified;
				db.SaveChanges();
			}
			txtColor.Text = "";

			fc.cbColorFill();
		}
	}
}
