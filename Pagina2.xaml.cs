
using Microsoft.Maui;

namespace TutorialesMaui;

public partial class Pagina2 : ContentPage
{
	public Pagina2()
	{
		InitializeComponent();
		
		CargaImagenes();
        
    }

	private Image curFileName = null;
	async void CargaImagenes()
	{
		
        var Imagenes = new List<string> { "iconouno.png", "iconodos.png","iconotres.png",
										  "iconocuatro.png","iconocinco.png","iconoseis.png",
			                              "iconosiete.png", "iconoocho.png", "icononueve.png", 
			                              "iconodiez.png", "iconoonce.png", "iconodoce.png", 
										  "iconotrece.png", "iconocatorce.png", "iconoquince.png",
										  "iconouno.png", "iconodos.png", "iconotres.png",
			                              "iconocuatro.png", "iconocinco.png", "iconoseis.png", 
			                              "iconosiete.png", "iconoocho.png", "icononueve.png", 
			                              "iconodiez.png", "iconoonce.png", "iconodoce.png",
			                              "iconotrece.png", "iconocatorce.png", "iconoquince.png" };
		foreach (var i in Imagenes)
		{
			Image cualquier = new Image
			{
				Source = ImageSource.FromFile(i)
			};
			
			flexLayout.Children.Add(cualquier);
		}
    }
}