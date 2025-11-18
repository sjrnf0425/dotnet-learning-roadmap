using MediatR;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
{
    public Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        // DB 대신 메모리 ID 생성
        return Task.FromResult(Guid.NewGuid());
    }
}