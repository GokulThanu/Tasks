using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

 namespace SpaceFlightNewsAPI
{
    public class ViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<Model> APIColection { get; set; }

		private Model selectedAPI;

        public event PropertyChangedEventHandler PropertyChanged;

        public Model SelectedAPI
        {
			get { return selectedAPI; }
			set { selectedAPI = value;
				OnPropertyChanged("SelectedAPI");
			}
		}
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ViewModel()
		{
			APIColection = new ObservableCollection<Model>();
			GenerateCollection();
		}

		private void GenerateCollection()
		{
			APIColection.Add(new Model { API = "AdoptAPet", Description = "Description:Resource to help get pets adopted\nAuth: apiKey,\nHTTPS: true,\nCors: yes,\nLink: https://www.adoptapet.com/public/apis/pet_list.html,\nCategory: Animals" });
			APIColection.Add(new Model { API = "Axolotl", Description = " Description: Collection of axolotl pictures and facts,\nAuth: ,\nHTTPS: true,\nCors: no,\nLink: https://theaxolotlapi.netlify.app/,\nCategory: Animals" });
			APIColection.Add(new Model { API = "Cat Facts", Description = "Description: Daily cat facts,\nAuth: ,\nHTTPS: true,\nCors: no,\nLink: https://alexwohlbruck.github.io/cat-facts/,\nCategory: Animals" });
			APIColection.Add(new Model { API = "Cataas", Description = "Description: Cat as a service (cats pictures and gifs),\nAuth: ,\nHTTPS: true,\nCors: no,\nLink: https://cataas.com/,\nCategory: Animals" });
			APIColection.Add(new Model { API = "eBird", Description = "Description: Retrieve recent or notable birding observations within a region,\nAuth: apiKey,\nHTTPS: true,\nCors: no,\nLink: https://documenter.getpostman.com/view/664302/S1ENwy59,\nCategory: Animals" });
			APIColection.Add(new Model { API = "FishWatch", Description = "Description: Information and pictures about individual fish species,\nAuth: ,\nHTTPS: true,\nCors: yes,\nLink: https://www.fishwatch.gov/developers,\nCategory: Animals" });
			APIColection.Add(new Model { API = "Movebank", Description = "Description: Movement and Migration data of animals,\nAuth: ,\nHTTPS: true,\nCors: yes,\nLink: https://github.com/movebank/movebank-api-doc,\nCategory: Animals" });
			APIColection.Add(new Model { API = "Améthyste", Description = "Description: Generate images for Discord users,\nAuth: apiKey,\nHTTPS: true,\nCors: unknown,\nLink: https://api.amethyste.moe/,\nCategory: Art & Design" });
			APIColection.Add(new Model { API = "Dribbble", Description = "Description: Discover the world’s top designers & creatives,\nAuth: OAuth,\nHTTPS: true,\nCors: unknown,\nLink: https://developer.dribbble.com,\nCategory: Art & Design" });
			APIColection.Add(new Model { API = "EmojiHub", Description = "Description: Get emojis by categories and groups,\nAuth: ,\nHTTPS: true,\nCors: yes,\nLink: https://github.com/cheatsnake/emojihub,\nCategory: Art & Design" });
			APIColection.Add(new Model { API = "Europeana", Description = "Description: European Museum and Galleries content,\nAuth: apiKey,\nHTTPS: true,\nCors: unknown,\nLink: https://pro.europeana.eu/resources/apis/search,\nCategory: Art & Design" });
			APIColection.Add(new Model { API = "SAWO Labs", Description = "Description: Simplify login and improve user experience by integrating passwordless authentication in your app,\nAuth: apiKey,\nHTTPS: true,\nCors: yes,\nLink: https://sawolabs.com,\nCategory: Authentication & Authorization" });
			APIColection.Add(new Model { API = "Stytch", Description = " Description: User infrastructure for modern applications,\nAuth: apiKey,\nHTTPS: true,\nCors: no,\nLink: https://stytch.com/,\nCategory: Authentication & Authorization" });
			APIColection.Add(new Model { API = "Helium", Description = "Description: Helium is a global, distributed network of Hotspots that create public, long-range wireless coverage,\nAuth: ,\nHTTPS: true,\nCors: unknown,\nLink: https://docs.helium.com/api/blockchain/introduction/,\nCategory: Blockchain" });
			APIColection.Add(new Model { API = "Nownodes", Description = "Description: Blockchain-as-a-service solution that provides high-quality connection via API,\nAuth: apiKey,\nHTTPS: true,\nCors: unknown,\nLink: https://nownodes.io/,\nCategory: Blockchain" });
			APIColection.Add(new Model { API = "The Graph", Description = "Description: Indexing protocol for querying networks like Ethereum with GraphQL,\nAuth: apiKey,\nHTTPS: true,\nCors: unknown,\nLink: https://thegraph.com,\nCategory: Blockchain" });
			APIColection.Add(new Model { API = "Walltime", Description = "Description: To retrieve Walltime's market info,\nAuth: ,\nHTTPS: true,\nCors: unknown,\nLink: https://walltime.info/api.html,\nCategory: Blockchain" });
			APIColection.Add(new Model { API = "Ganjoor", Description = "Description: Classic Persian poetry works including access to related manuscripts, recitations and music tracks,\nAuth: OAuth,\nHTTPS: true,\nCors: yes,\nLink: https://api.ganjoor.net,\nCategory: Books" });
			APIColection.Add(new Model { API = "Gutendex", Description = "Description: Web-API for fetching data from Project Gutenberg Books Library,\nAuth: ,\nHTTPS: true,\nCors: unknown,\nLink: https://gutendex.com/,\nCategory: Books" });
			APIColection.Add(new Model { API = "Trello", Description = " Description: Boards, lists and cards to help you organize and prioritize your projects,\nAuth: OAuth,\nHTTPS: true,\nCors: unknown,\nLink: https://developers.trello.com/,\nCategory: Business" });

		}
	}
}
