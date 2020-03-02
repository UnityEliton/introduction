using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListLeaderboard : MonoBehaviour
{
    public Text textResultado;
    public Button buttonAdd;
    public Button buttonRemove;
    public InputField entradaPontos;
    public InputField entradaNome;
    string texto = "Vazia";
    List<User> listaUser = new List<User>();
    // Start is called before the first frame update
    void Start()
    {
        buttonAdd.onClick.AddListener(addUser);
        buttonRemove.onClick.AddListener(removeUser);
    }

    void removeUser()
    {
        /*int num = int.Parse(entradaDados.text);
        if (listaNumeros.Contains(num))
            listaNumeros.Remove(num);
        else
            print("Número não está na lista");
        print(num);*/
    }
    void addUser()
    {
        int num = int.Parse(entradaPontos.text);
        string nome = entradaNome.text;
        /*User user = new User(nome, num);*/
        listaUser.Add(new User(nome, num));
    }
    string getTexto()
    {
        texto = "";
        listaUser.Sort( delegate (User x, User y)
        {
            return x.pontos.CompareTo(y.pontos);
        });
        foreach (var user in listaUser)
        {
            texto = texto + user.pontos + " " + 
                user.nome + "\n";
        }
        return texto;
    }

    // Update is called once per frame
    void Update()
    {
        textResultado.text = getTexto();
    }
}
