namespace jlicuyExamen.Vistas;

public partial class vResumen : ContentPage
{
    public vResumen(string nombre, string apellido, string edad, string fecha, string pais, string ciudad, string montoInicial, string pagoMensual)
    {
        InitializeComponent();

        nombreEntry.Text = nombre;
        apellidoEntry.Text = apellido;
        edadEntry.Text = edad;
        fechaEntry.Text = fecha;
        paisEntry.Text = pais;
        ciudadEntry.Text = ciudad;
        montoInicialEntry.Text = montoInicial;
        pagoMensualEntry.Text = pagoMensual;

    }

   
    private async void Salir_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}