using UnityEngine;

public class Xama : Personagem
{
    public enum Totens
    {
        ESPIRITOS,
        CURA
    }

    public Totens totemAtual;

    public void DefinirTotem(Totens totem)
    {
        totemAtual = totem;
    }

    public int RealizarCura()
    {
        int cura = 0;

        switch (totemAtual)
        {
            case Totens.ESPIRITOS:
                cura = AtribuirIntensidadeCuraBase() + 10;
                break;
            case Totens.CURA:
                cura = AtribuirIntensidadeCuraBase() + 18;
                break;
        }

        return cura;
    }

    private int AtribuirIntensidadeCuraBase()
    {
        return 20;
    }

    void Start()
    {
        AtribuirNome("zoro");
        DefinirTotem(Totens.ESPIRITOS);

        Debug.Log("Nome: " + Nome());
        Debug.Log("Totem Atual: " + totemAtual);
        Debug.Log("Cura Realizada: " + RealizarCura());
    }

    void Update()
    {
        // Atualizações por frame (se precisar)
    }
}