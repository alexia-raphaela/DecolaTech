using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
  // Essa classe repositorio implementa uma intereface e repositorio de serie
  public class SerieRepositorio : IRepositorio<Serie>
  {
      // esta variavel sera a minha lista com todas as series
    private List<Serie> listaSerie = new List<Serie>();
    public void Atualiza(int id, Serie objeto)
    {
        // recebo id para pegar aquele elemento do vetor
        // ele vai pegar o objeto e colocar em uma posição no vetor da minha listaSerie
        listaSerie[id] = objeto;
    }

    public void Exclui(int id)
    {
        // pode dar problema pois o removeAt quando executado ele redefinir as posicoes, os indices dos elementos no vetor
        // listaSerie.RemoveAt(id);
        listaSerie[id].Excluir();
    }

    public void Insere(Serie objeto)
    {
        listaSerie.Add(objeto);
    }

    public List<Serie> Lista()
    {
        return listaSerie;
    }

    public int ProximoId()
    {
        return listaSerie.Count;
    }

    public Serie RetornaPorId(int id)
    {
        // ira retornar minha lista de serie passado por um id
        return listaSerie[id];
    }
  }
}