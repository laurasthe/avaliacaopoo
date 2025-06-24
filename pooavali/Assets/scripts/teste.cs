using UnityEngine;

public class teste : MonoBehaviour
{
    void Start()
    {
        Gunslinger gunslinger = new GameObject("Gunslinger").AddComponent<Gunslinger>();
        gunslinger.AtribuirNome("pisi");
        gunslinger.AtribuirAtaque(30);
        gunslinger.AtribuirArma(Gunslinger.ArmaDoGunslinger.TIRORAPIDO);
        
        
     
        Personagem personagem = new GameObject("Personagem").AddComponent<Personagem>();
        personagem.AtribuirNome("poti");
        personagem.AtribuirEnergia(87);   
        personagem.AtribuirAtaque(11);
        personagem.AtribuirVelocidade(6);

        Debug.Log("--- Combate Iniciado ---");
        Debug.Log(gunslinger.Nome() + " (Gunslinger) VS " + personagem.Nome());
        Debug.Log("Arma do Gunslinger: " + gunslinger.Arma());
        Debug.Log(personagem.Nome() + " tem agora " + personagem.Energia() + " de energia.");
    }

    void Update()
    {
        // Atualizações frame a frame, se necessário
    }
}