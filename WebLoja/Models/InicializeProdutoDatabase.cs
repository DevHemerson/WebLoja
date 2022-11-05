using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebLoja.Models
{
    public class InicializeProdutoDatabase : DropCreateDatabaseIfModelChanges<ProdutoContext>
    {
        protected override void Seed(ProdutoContext context)
        {
            GetCategorias().ForEach(c => context.Categorias.Add(c));
            GetProdutos().ForEach(p => context.Produtos.Add(p));
        }

        private static List<Categoria> GetCategorias()
        {
            var categorias = new List<Categoria> {
                new Categoria
                {
                    CategoriaID = 1,
                    NomeCategoria = "Cars"
                },
                new Categoria
                {
                    CategoriaID = 2,
                    NomeCategoria = "Planes"
                },
                new Categoria
                {
                    CategoriaID = 3,
                    NomeCategoria = "Trucks"
                },
                new Categoria
                {
                    CategoriaID = 4,
                    NomeCategoria = "Boats"
                },
                new Categoria
                {
                    CategoriaID = 5,
                    NomeCategoria = "Rockets"
                },
            };

            return categorias;
        }

        private static List<Produto> GetProdutos()
        {
            var produtos = new List<Produto> {
                new Produto
                {
                    ProdutoID = 1,
                    NomeProduto = "Carro Conversível",
                    Descricao = "Este carro conversível é rápido! O motor é alimentado por uma bateria baseada em neutrinos (não incluída)." +
                                  "Ligue-o e deixe-o ir!", 
                    ImagePath="carconvert.png",
                    PrecoUnidade = 22.50,
                    CategoriaID = 1
               },
                new Produto 
                {
                    ProdutoID = 2,
                    NomeProduto = "Old-time Car",
                    Descricao = "There's nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
                    ImagePath="carearly.png",
                    PrecoUnidade = 15.95,
                     CategoriaID = 1
               },
                new Produto
                {
                    ProdutoID = 3,
                    NomeProduto = "Fast Car",
                    Descricao = "Yes this car is fast, but it also floats in water.",
                    ImagePath="carfast.png",
                    PrecoUnidade = 32.99,
                    CategoriaID = 1
                },
                new Produto
                {
                    ProdutoID = 4,
                    NomeProduto = "Super Fast Car",
                    Descricao = "Use this super fast car to entertain guests. Lights and doors work!",
                    ImagePath="carfaster.png",
                    PrecoUnidade = 8.95,
                    CategoriaID = 1
                },
                new Produto
                {
                    ProdutoID = 5,
                    NomeProduto = "Old Style Racer",
                    Descricao = "This old style racer can fly (with user assistance). Gravity controls flight duration." + 
                                  "No batteries required.",
                    ImagePath="carracer.png",
                    PrecoUnidade = 34.95,
                    CategoriaID = 1
                },
                new Produto
                {
                    ProdutoID = 6,
                    NomeProduto = "Ace Plane",
                    Descricao = "Authentic airplane toy. Features realistic color and details.",
                    ImagePath="planeace.png",
                    PrecoUnidade = 95.00,
                    CategoriaID = 2
                },
                new Produto
                {
                    ProdutoID = 7,
                    NomeProduto = "Glider",
                    Descricao = "This fun glider is made from real balsa wood. Some assembly required.",
                    ImagePath="planeglider.png",
                    PrecoUnidade = 4.95,
                    CategoriaID = 2
                },
                new Produto
                {
                    ProdutoID = 8,
                    NomeProduto = "Paper Plane",
                    Descricao = "This paper plane is like no other paper plane. Some folding required.",
                    ImagePath="planepaper.png",
                    PrecoUnidade = 2.95,
                    CategoriaID = 2
                },
                new Produto
                {
                    ProdutoID = 9,
                    NomeProduto = "Propeller Plane",
                    Descricao = "Rubber band powered plane features two wheels.",
                    ImagePath="planeprop.png",
                    PrecoUnidade = 32.95,
                    CategoriaID = 2
                },
                new Produto
                {
                    ProdutoID = 10,
                    NomeProduto = "Early Truck",
                    Descricao = "This toy truck has a real gas powered engine. Requires regular tune ups.",
                    ImagePath="truckearly.png",
                    PrecoUnidade = 15.00,
                    CategoriaID = 3
                },
                new Produto
                {
                    ProdutoID = 11,
                    NomeProduto = "Fire Truck",
                    Descricao = "You will have endless fun with this one quarter sized fire truck.",
                    ImagePath="truckfire.png",
                    PrecoUnidade = 26.00,
                    CategoriaID = 3
                },
                new Produto
                {
                    ProdutoID = 12,
                    NomeProduto = "Big Truck",
                    Descricao = "This fun toy truck can be used to tow other trucks that are not as big.",
                    ImagePath="truckbig.png",
                    PrecoUnidade = 29.00,
                    CategoriaID = 3
                },
                new Produto
                {
                    ProdutoID = 13,
                    NomeProduto = "Big Ship",
                    Descricao = "Is it a boat or a ship. Let this floating vehicle decide by using its " + 
                                  "artifically intelligent computer brain!",
                    ImagePath="boatbig.png",
                    PrecoUnidade = 95.00,
                    CategoriaID = 4
                },
                new Produto
                {
                    ProdutoID = 14,
                    NomeProduto = "Paper Boat",
                    Descricao = "Floating fun for all! This toy boat can be assembled in seconds. Floats for minutes!" + 
                                  "Some folding required.",
                    ImagePath="boatpaper.png",
                    PrecoUnidade = 4.95,
                    CategoriaID = 4
                },
                new Produto
                {
                    ProdutoID = 15,
                    NomeProduto = "Sail Boat",
                    Descricao = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath="boatsail.png",
                    PrecoUnidade = 42.95,
                    CategoriaID = 4
                },
                new Produto
                {
                    ProdutoID = 16,
                    NomeProduto = "Rocket",
                    Descricao = "This fun rocket will travel up to a height of 200 feet.",
                    ImagePath="rocket.png",
                    PrecoUnidade = 122.95,
                    CategoriaID = 5
                }
            };

            return produtos;
        }
    }
}