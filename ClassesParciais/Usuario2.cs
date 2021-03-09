using System;

public partial class Usuario
{
    public bool Autenticar()
    {
        return ((Nome == "Adriel") & (Senha == "010241"));
    }
}