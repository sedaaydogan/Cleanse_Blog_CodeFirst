namespace CleanseBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Etikets",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        adi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Makales",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        baslik = c.String(),
                        icerik = c.String(),
                        yayinTarihi = c.DateTime(nullable: false),
                        kategoriId = c.Int(nullable: false),
                        yazarId = c.Int(nullable: false),
                        resimId = c.Int(nullable: false),
                        goruntulenme = c.Int(nullable: false),
                        begeni = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Kategoris", t => t.kategoriId, cascadeDelete: true)
                .ForeignKey("dbo.Resims", t => t.resimId, cascadeDelete: true)
                .ForeignKey("dbo.Yazars", t => t.yazarId, cascadeDelete: true)
                .Index(t => t.kategoriId)
                .Index(t => t.yazarId, unique: true)
                .Index(t => t.resimId);
            
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        adi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Resims",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        adi = c.String(),
                        kckResimYol = c.String(),
                        ortResimYol = c.String(),
                        bykResimYol = c.String(),
                        eklenmeTarih = c.DateTime(nullable: false),
                        goruntulenme = c.Int(nullable: false),
                        begeni = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Yazars",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        adi = c.String(),
                        soyadi = c.String(),
                        mail = c.String(),
                        kayitTarih = c.DateTime(nullable: false),
                        nick = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.MakaleEtikets",
                c => new
                    {
                        Makale_id = c.Int(nullable: false),
                        Etiket_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Makale_id, t.Etiket_id })
                .ForeignKey("dbo.Makales", t => t.Makale_id, cascadeDelete: true)
                .ForeignKey("dbo.Etikets", t => t.Etiket_id, cascadeDelete: true)
                .Index(t => t.Makale_id)
                .Index(t => t.Etiket_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Makales", "yazarId", "dbo.Yazars");
            DropForeignKey("dbo.Makales", "resimId", "dbo.Resims");
            DropForeignKey("dbo.Makales", "kategoriId", "dbo.Kategoris");
            DropForeignKey("dbo.MakaleEtikets", "Etiket_id", "dbo.Etikets");
            DropForeignKey("dbo.MakaleEtikets", "Makale_id", "dbo.Makales");
            DropIndex("dbo.MakaleEtikets", new[] { "Etiket_id" });
            DropIndex("dbo.MakaleEtikets", new[] { "Makale_id" });
            DropIndex("dbo.Makales", new[] { "resimId" });
            DropIndex("dbo.Makales", new[] { "yazarId" });
            DropIndex("dbo.Makales", new[] { "kategoriId" });
            DropTable("dbo.MakaleEtikets");
            DropTable("dbo.Yazars");
            DropTable("dbo.Resims");
            DropTable("dbo.Kategoris");
            DropTable("dbo.Makales");
            DropTable("dbo.Etikets");
        }
    }
}
