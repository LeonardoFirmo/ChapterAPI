using ChapterAPI.Contexts;
using ChapterAPI.Interfaces;
using ChapterAPI.Models;

namespace ChapterAPI.Repositories
{

    public class LivroRepository : ILivroRepository
    {
        //variável privada criada para armazenar os dados do context
        private readonly ChapterContext _chapterContext;

        //injeção de dependência: o repository depende do context
        public LivroRepository(ChapterContext context)
        {
            _chapterContext = context;
        }

        //método implementado da interface
        public List<Livro> Ler()
        {
            return _chapterContext.Livros.ToList();
        }
    }
}
