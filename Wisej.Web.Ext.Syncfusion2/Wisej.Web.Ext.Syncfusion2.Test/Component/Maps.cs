using System;
using System.Drawing;
using System.IO;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class Maps : Wisej.Web.Ext.Syncfusion2.Test.Component.TestBase
	{
		public Maps()
		{
			InitializeComponent();
		}

		private void Maps_Load(object sender, EventArgs e)
		{
			// load the map's json file.
			var worldText = File.ReadAllText(Application.MapPath("Data/Maps/WorldMap_Countries.json"));
			this.maps1.Options.layers = new[] {
				new
				{
					shapeData = JSON.Parse(worldText),
					// load markers and configuration.
					markerSettings = new[]
					{
						new
						{
							dataSource = PopulateDataSource(),
							visible = true,
							shape = "Circle",
							fill = Color.White,
							width = 10,
							border = new
							{
								width = 2,
								color = Color.Blue
							},
							tooltipSettings = new 
							{
								format = "City: ${city} <br> Population: ${population}",
								visible = true,
								valuePath = "city"
							}
						}
					}
				},
			};

			// enable zoom.
			this.maps1.Options.zoomSettings = new
			{
				enable = true
			};

			this.maps1.Update();
		}

		/// <summary>
		/// Generates a data source with a few cities.
		/// </summary>
		/// <returns></returns>
		private object PopulateDataSource()
		{
			return new[] 
			{ 
				new {
					city = "New York City",
					latitude = 40.71427,
					longitude = -74.00597,
					population = "8.39M"
				},
				new {
					city = "Los Angeles",
					latitude = 34.052235,
					longitude = -118.243683,
					population = "3.99M"
				},
				new {
					city = "London",
					latitude = 51.508530,
					longitude = -0.076132,
					population = "8.982M"
				},
			};
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// adds a new marker to the map.
			this.maps1.Instance.addMarker(0, new[] 
			{
				new
				{
					dataSource = new[] {
						new {
						city = "Chicago",
						latitude = 41.1881832,
						longitude = -87.623177,
						population = "2.706M"
						}
					},
					visible = true,
					shape = "Circle",
					fill = Color.White,
					width = 10,
					border = new
					{
						width = 2,
						color = Color.Red
					},
					tooltipSettings = new
					{
						format = "City: ${city} <br> Population: ${population}",
						visible = true,
						valuePath = "city"
					}
				}
			});
		}
	}
}
