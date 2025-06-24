using UnityEngine;

public class teste : MonoBehaviour
{
    void Start()
    {
        // Cria o Xama (personagem que cura)
        Xama xama = new GameObject("Xama").AddComponent<Xama>();
        xama.AtribuirNome("Sopro");
        xama.DefinirTotem(Xama.Totens.ESPIRITOS);  // Define o totem para cura

        // Cria outro personagem genérico para exemplo
        Personagem personagem = new GameObject("Personagem").AddComponent<Personagem>();
        personagem.AtribuirNome("Sol");
        personagem.AtribuirEnergia(80);    // Precisa implementar esse método na Personagem
        personagem.AtribuirAtaque(10);
        personagem.AtribuirVelocidade(3);

        Debug.Log("--- Combate Iniciado ---");
        Debug.Log(xama.Nome() + " (Xamã) VS " + personagem.Nome());
        Debug.Log("Totem do Xamã: " + xama.totemAtual);
        Debug.Log("Cura realizada pelo Xamã: " + xama.RealizarCura());

        // Aplicar cura no personagem
        personagem.AtribuirAtaque(xama.RealizarCura());

        Debug.Log(personagem.Nome() + " recebeu cura. Energia atual: " + personagem.AtribuirEnergia());
    }

    void Update()
    {
        // Atualizações frame a frame, se necessário
    }
}