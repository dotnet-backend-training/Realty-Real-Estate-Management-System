using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Application.Shared.Result;
using System.Net;

public class ValidationRuleSet<TContext>
{
    private readonly IEnumerable<IValidationRule<TContext>> _rules;

    public ValidationRuleSet(IEnumerable<IValidationRule<TContext>> rules)
    {
        _rules = rules;
    }

    public async Task<Result> ValidateAllAsync(TContext context)
    {
        foreach (var rule in _rules)
        {
            var result = await rule.ValidateAsync(context);
            if (!result.Success)
                return result;
        }
        return SuccessResult.Create(
              statusCode: (int)(HttpStatusCode.OK),
              message: "All validation rules successful."
          );
    }
}
