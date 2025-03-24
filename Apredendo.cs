class Arma
^{
    int balasPorPent = 20;
    int qntBalasAtuais;
    float tempoDeRecarga = 5.0f;
    float tempoEntreDisparos = 0.2f;

    void Atirar ()
    {
        qntBalasAtuais -= 1 * tempoEntreDisparos;
    }
    void Recarregar ()
{
    se qntBalasAtuais < balasPorPent
    {
        qntBalasAtuais += 1 * tempoDeRecarga;
    }
}
}