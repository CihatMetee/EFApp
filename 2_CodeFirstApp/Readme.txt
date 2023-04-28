

EF CodeFirst İşlemleri

1-Models oluşturulur
2-Entity Framework Nuget package den yüklenir
3-DbContext clasından kalıtım alacak class oluşturulur. 

DbContext clasından->Database table'a  karşılık gelecek Modeller Dbset içerisnde belirtilir.Crud işlemer bu classdan kalıtım alacak nesne sayesinde Crud işlemler yapılır.

4-App.config dosyasına connectionString yazılır.
	connectionstring name DbContext clası ile aynı
5-
Proje Rebuild edilmeli 
Migration işlemi Nuget Package Console da yapılır.
	enable-migrations
	add-migration migration_adi
	Configuration.cs 
	ctor
	 AutomaticMigrationsEnabled = true;
     AutomaticMigrationDataLossAllowed = true;
	!Migration : Model değişikliğini algılayan classa

6-Nuget Package Console'a
	update-database
