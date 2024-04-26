namespace jlicuyExamen.Vistas;

public partial class vRegistro : ContentPage
{
    private string usuario;

    
    public vRegistro()
    {
        InitializeComponent();
  
        DisplayAlert("Alerta", "Bienvenido, usuario desconocido", "Cerrar");
        usuario = string.Empty;
    }

    
    public vRegistro(string usuario)
    {
        InitializeComponent();
        this.usuario = usuario; 
        DisplayAlert("Alerta", "Bienvenido " + this.usuario, "Cerrar");
        lblUsuario.Text = "Usuario conectado: " + this.usuario;
    }

    private void btnCalcularPMensual_Clicked(object sender, EventArgs e)
    {
        const double costoCurso = 1500;
        double montoInicialValue;
        if (!double.TryParse(montoInicial.Text, out montoInicialValue) || montoInicialValue <= 0 || montoInicialValue >= costoCurso)
        {
            DisplayAlert("Error", "El monto inicial debe ser mayor que 0 y menor que el costo total del curso ($1500).", "OK");
            return;
        }

        double saldoRestante = costoCurso - montoInicialValue;
        double pagoMensualSinInteres = saldoRestante / 4;
        double pagoMensualConInteres = pagoMensualSinInteres + (costoCurso * 0.04);

        pagoMensual.Text = pagoMensualConInteres.ToString("F2"); 
    }


    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = datePicker.Date.ToString("yyyy-MM-dd");
        string pais = paisPicker.SelectedItem.ToString();
        string ciudad = ciudadPicker.SelectedItem.ToString();
        string montoInicial1 = montoInicial.Text;
        string pagoMensual1 = pagoMensual.Text;

        vResumen resumenPage = new vResumen(nombre, apellido, edad, fecha, pais, ciudad, montoInicial1, pagoMensual1);
        Navigation.PushAsync(resumenPage);
    }
}