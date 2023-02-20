using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {Name="Kamera",Description="Kamera Ürünleri"},
                new Category() {Name="Telefon",Description="Telefon Ürünleri"},
                new Category() {Name="Bilgisayar",Description="Bilgisayar Ürünleri"}
            };
            foreach (var Kategori in kategoriler)
            {
                context.Categoris.Add(Kategori);
            }
            context.SaveChanges();
            var Urunler = new List<Product>()
            { 
                new Product() {Name="Canon", Description="Kamera Ürünleri", Price=2500,Stok=125,IsHome=true,IsApproved=true,IsFeatured=false,Slider=true,CategoryId=1,İmage="1.jpg"},
                new Product() {Name="Asus", Description="Bilgisayar Ürünleri", Price=2000,Stok=100,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=3,İmage="2.jpg"},
                new Product() {Name="Lenova", Description="Bilgisayar Ürünleri", Price=3500,Stok=50,IsHome=false,IsApproved=true,IsFeatured=true,Slider=false,CategoryId=3,İmage="3.jpg"},
                new Product() {Name="İphone 13mini", Description="Telefon Ürünleri", Price=11000,Stok=25,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=2,İmage="4.jpg"},
            };
            foreach (var Urun in Urunler)
            {
                context.Products.Add(Urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}