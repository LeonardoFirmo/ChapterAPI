using ChapterAPI.Models;

namespace ChapterAPI.Interfaces
{
    /// <summary>
    /// Interface ILivroRepository
    /// </summary>
    public interface ILivroRepository
    {
        //método que deverá ser implementado pela classe que herdar desta interface
        List<Livro> Ler();

        void Cadastrar(Livro livro);

        void Atualizar(int id, Livro livro);

        void Deletar(int id);

        Livro BuscarPorId(int id);

        Livro BuscarPorTitulo(string titulo);
    }
}
