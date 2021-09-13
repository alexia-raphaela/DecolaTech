using System;

// é como se fosse uma bl=iblioteca e que eu posso chamar em outro arquivo
namespace EstruturaDoPrograma.Exemplos
{
    public class Pilha
    {
        Posicao primeiro;

        // é o principal metodo da classe, é um metodo construtor porque não retorna nada
        public void Empilha(object item)
        {
            primeiro = new Posicao(primeiro, item);
        }

        // é um metodo auxiliar porque ele sempre retorna algo, ajuda no onjetivo da classe 
        public object Desempilha()
        {
            if (primeiro == null)
            {
                // ira interromper a execução e lançar um erro
                throw new InvalidOperationException("A pilha está vazia!");
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }

        class Posicao
        {
            public Posicao proximo;
            public object item;
            public Posicao(Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }
        }
    }
}