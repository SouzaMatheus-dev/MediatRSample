using MediatR;

public class CadastraPessoaCommandHandler : IRequestHandler<CadastraPessoaCommand, string>
{
    private readonly IMediator _mediator;
    private readonly IRepository<Pessoa> _repository;

    public CadastraPessoaCommandHandler(IMediator mediator, IRepository<Pessoa> repository)
    {
        this._mediator = mediator;
        this._repository = repository;
    }

    public async Task<string> Handle(CadastraPessoaCommand request, CancellationToken cancellationToken)
    {
        Random random = new Random();

        int randomNumber = random.Next(0, 10000);

        var pessoa = new Pessoa { Id = randomNumber, Nome = request.Nome, Idade = request.Idade, Sexo = request.Sexo };

        try
        {
            await _repository.Add(pessoa);

            await _mediator.Publish(new PessoaCriadaNotification { Id = pessoa.Id, Nome = pessoa.Nome, Idade = pessoa.Idade, Sexo = pessoa.Sexo });

            return await Task.FromResult("Pessoa criada com sucesso");
        }
        catch (Exception ex)
        {
            await _mediator.Publish(new PessoaCriadaNotification { Id = pessoa.Id, Nome = pessoa.Nome, Idade = pessoa.Idade, Sexo = pessoa.Sexo });
            await _mediator.Publish(new ErroNotification { Excecao = ex.Message, PilhaErro = ex.StackTrace });
            return await Task.FromResult("Ocorreu um erro no momento da criação");
        }
    }
}