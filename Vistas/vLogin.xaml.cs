namespace jlicuyExamen.Vistas;

public partial class vLogin : ContentPage
{

    string[] usuarios = { "estudiante2024", "examen1", "NombreEstudiante" };
    string[] passwords = { "uisrael2024", "parcial1", "2024" };

    
    public vLogin()
	{
		InitializeComponent();
	}
    
    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuarioIngresado = txtUsuario.Text;
        string contrasenaIngresada = txtContrasena.Text;

        bool usuarioValido = false;

        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarioIngresado == usuarios[i] && contrasenaIngresada == passwords[i])
            {
                usuarioValido = true;
                break;
            }
        }

        if (usuarioValido)
        {
            Navigation.PushAsync(new vRegistro(usuarioIngresado));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contraseña incorrectos", "Cerrar");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vAcerca());
    }
}