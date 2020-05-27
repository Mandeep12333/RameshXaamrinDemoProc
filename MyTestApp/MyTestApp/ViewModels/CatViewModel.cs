using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MyTestApp.Models;
using Xamarin.Forms;
using MyTestApp.Views;
using MyTestApp.Data;

namespace MyTestApp.ViewModels
{
    public class CatViewModel: BindableObject, INotifyPropertyChanged
    {

        //ObservableCollection<CatModel> cats = new ObservableCollection<CatModel>();
        //public ObservableCollection<CatModel> Cats { get { return cats; } }
        //public Command newCommand { get; }

        //public CatViewModel() {

        //    Cats.Add(new CatModel
        //    {
        //        Name = "Abyssinian",
        //        Location = "Ethopia",
        //        Details = "The Abyssinian is a breed of domestic short-haired cat with a distinctive tickedtabby coat, in which individual hairs are banded with different colors. The breed is named for Abyssinia (now called Ethiopia), where it is believed to have originated.",
        //        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9b/Gustav_chocolate.jpg/168px-Gustav_chocolate.jpg"
        //    });

        //    Cats.Add(new CatModel
        //    {
        //        Name = "Arabian Mau",
        //        Location = "Arabian Peninsula",
        //        Details = "The Arabian Mau is a formal breed of domestic cat, originated from the desert cat, a short-haired landrace native to the desert of the Arabian Peninsula. It lives there in the streets and has adapted very well to the extreme climate. The Arabian Mau is recognized as a formal breed by few fancier and breeder organization and cat registry, World Cat Federation (WCF) and Emirates Feline Federation (EFF). Based on one landrace, the Arabian Mau is a natural breed.",
        //        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d3/Bex_Arabian_Mau.jpg"
        //    });

        //    Cats.Add(new CatModel
        //    {
        //        Name = "Bengal",
        //        Location = "Asia",
        //        Details = "The Bengal cat is a domesticated cat breed created from hybrids of domestic cats and the Asian leopard cat – the breed name comes from the taxonomic name. Back-crossing to domestic cats is then done with the goal of creating a healthy, and docile cat with wild-looking, high-contrast coat. Bengals have a wild appearance and may show spots, rosettes, arrowhead markings, or marbling.",
        //        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Paintedcats_Red_Star_standing.jpg/187px-Paintedcats_Red_Star_standing.jpg"
        //    });

        //    this.BindingContext = this;

        //    newCommand = new Command(() => {
        //        Cats.Add(new CatModel
        //        {
        //            Name = "Bengal",
        //            Location = "Asia",
        //            Details = "The Bengal cat is a domesticated cat breed created from hybrids of domestic cats and the Asian leopard cat – the breed name comes from the taxonomic name. Back-crossing to domestic cats is then done with the goal of creating a healthy, and docile cat with wild-looking, high-contrast coat. Bengals have a wild appearance and may show spots, rosettes, arrowhead markings, or marbling.",
        //            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Paintedcats_Red_Star_standing.jpg/187px-Paintedcats_Red_Star_standing.jpg"
        //        });
        //    });
        //}

      
            public ObservableCollection<CatModel> cats = new ObservableCollection<CatModel>();
            public ObservableCollection<CatModel> Cats
            {
                get
                {
                    return cats;
                }
                set
                {
                    cats = value;
                    OnPropertyChanged(nameof(Cats));
                }
            }
            public Command newCommand { get; }
            public CatViewModel()
            {
                Cats.Add(new CatModel
                {
                    Name = "Abyssinian",
                    Location = "Ethopia",
                    Details = "The Abyssinian is a breed of domestic short-haired cat with a distinctive tickedtabby coat, in which individual hairs are banded with different colors. The breed is named for Abyssinia (now called Ethiopia), where it is believed to have originated.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9b/Gustav_chocolate.jpg/168px-Gustav_chocolate.jpg"
                });
                Cats.Add(new CatModel
                {
                    Name = "Arabian Mau",
                    Location = "Arabian Peninsula",
                    Details = "The Arabian Mau is a formal breed of domestic cat, originated from the desert cat, a short-haired landrace native to the desert of the Arabian Peninsula. It lives there in the streets and has adapted very well to the extreme climate. The Arabian Mau is recognized as a formal breed by few fancier and breeder organization and cat registry, World Cat Federation (WCF) and Emirates Feline Federation (EFF). Based on one landrace, the Arabian Mau is a natural breed.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d3/Bex_Arabian_Mau.jpg"
                });
                Cats.Add(new CatModel
                {
                    Name = "Bengal",
                    Location = "Asia",
                    Details = "The Bengal cat is a domesticated cat breed created from hybrids of domestic cats and the Asian leopard cat – the breed name comes from the taxonomic name. Back-crossing to domestic cats is then done with the goal of creating a healthy, and docile cat with wild-looking, high-contrast coat. Bengals have a wild appearance and may show spots, rosettes, arrowhead markings, or marbling.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Paintedcats_Red_Star_standing.jpg/187px-Paintedcats_Red_Star_standing.jpg"
                });
                this.BindingContext = this;
                newCommand = new Command(() => {
                    Cats.Add(new CatModel
                    {
                        Name = "Bengal",
                        Location = "Asia",
                        Details = "The Bengal cat is a domesticated cat breed created from hybrids of domestic cats and the Asian leopard cat – the breed name comes from the taxonomic name. Back-crossing to domestic cats is then done with the goal of creating a healthy, and docile cat with wild-looking, high-contrast coat. Bengals have a wild appearance and may show spots, rosettes, arrowhead markings, or marbling.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Paintedcats_Red_Star_standing.jpg/187px-Paintedcats_Red_Star_standing.jpg"
                    });
                });
            }
        } 
    }


