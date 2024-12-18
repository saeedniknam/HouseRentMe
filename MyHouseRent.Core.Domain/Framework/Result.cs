using System.Diagnostics.CodeAnalysis;

namespace HouseRent.Core.Domain.Framework;

public class Result
{
    protected Result(bool isSuccessful, Error error)
    {
        if (isSuccessful && error != Error.Nothing)
        {
            throw new InvalidOperationException();
        }
        if (!isSuccessful && error == Error.Nothing)
        {
            throw new InvalidOperationException();
        }
        IsSuccessful = isSuccessful;
        Error = error;
    }

    public bool IsSuccessful { get; }
    public Error Error { get; }
    public bool IsFailure => !IsSuccessful;
    public static Result Success() => new(true, Error.Nothing);
    public static Result Failed(Error error) => new(false, error);
    public static Result<TValue> Success<TValue>(TValue value) => new(value, true, Error.Nothing);

    public static Result<TValue> Failed<TValue>(Error error) => new(default, false, error);

    public static Result<TValue> Create<TValue>(TValue? value) =>
        value is not null ? Success(value) : Failed<TValue>(Error.NullValue);

}
public class Result<TValue> : Result
{
    private readonly TValue? _value;

    protected internal Result(TValue? value, bool isSuccess, Error error)
        : base(isSuccess, error) => _value = value;

    [NotNull]
    public TValue Value => IsSuccessful
        ? _value!
        : throw new InvalidOperationException("Invalid access to failure result.");

    public static implicit operator Result<TValue>(TValue? value) => Create(value);
}
