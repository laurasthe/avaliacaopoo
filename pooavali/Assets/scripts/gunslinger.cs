using UnityEngine;

public class   Gunslinger : Personagem
{
    public enum ArmaDoGunslinger
    {
        PISTOLASDUPLAS,
        TIRORAPIDO
    }

    private ArmaDoGunslinger armaDoGunslinger;

    public void AtribuirArma(ArmaDoGunslinger arma)
    {
        this.armaDoGunslinger = arma;
    }

    public ArmaDoGunslinger Arma()
    {
        return this.armaDoGunslinger;
    }


    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (armaDoGunslinger)
        {
            case ArmaDoGunslinger.PISTOLASDUPLAS:
                dano = Forca_Ataque() + 10;
                break;
            case ArmaDoGunslinger.TIRORAPIDO:
                dano = Forca_Ataque() + 18;
                break;

        }

        // dano do ataque com a arma

        return dano;






    }


    void Start()
    {

        {
            // Exemplo de teste:
            AtribuirNome("zoro");
            AtribuirAtaque(20);
            AtribuirArma(ArmaDoGunslinger.PISTOLASDUPLAS);

            Debug.Log("Nome: " + Nome());
            Debug.Log("Ataque Base: " + Forca_Ataque());
            Debug.Log("Arma: " + Arma());
            Debug.Log("Dano do Gunslinger: " + DanoDoInimigo());
        }


        {

        }
    }


    void Update()
    {

    }
}