﻿/*using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Google.Apis.Util;

namespace Ryzhanovskyi.University.Tinder.Web.Pages
{
    public class AuthorizeIndexPageHandlerFilter : IAsyncPageFilter, IOrderedFilter
    {
        private readonly IAuthorizationPolicyProvider policyProvider;
        private readonly IPolicyEvaluator policyEvaluator;

        public AuthorizeIndexPageHandlerFilter(
            IAuthorizationPolicyProvider policyProvider,
            IPolicyEvaluator policyEvaluator)
        {
            this.policyProvider = policyProvider;
            this.policyEvaluator = policyEvaluator;
        }

        // Run late in the selection pipeline
        public int Order => 10000;

        public Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next) => next();

        public async Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            var attribute = context.HandlerMethod?.MethodInfo?.GetCustomAttribute<AuthorizePageHandlerAttribute>();
            if (attribute is null)
            {
                return;
            }

            var policy = await AuthorizationPolicy.CombineAsync(policyProvider, new[] { attribute });
            if (policy is null)
            {
                return;
            }

            await AuthorizeAsync(context, policy);
        }

        #region AuthZ - do not change
        private async Task AuthorizeAsync(ActionContext actionContext, AuthorizationPolicy policy)
        {
            var httpContext = actionContext.HttpContext;
            var authenticateResult = await policyEvaluator.AuthenticateAsync(policy, httpContext);
            var authorizeResult = await policyEvaluator.AuthorizeAsync(policy, authenticateResult, httpContext, actionContext.ActionDescriptor);
            if (authorizeResult.Challenged)
            {
                if (policy.AuthenticationSchemes.Count > 0)
                {
                    foreach (var scheme in policy.AuthenticationSchemes)
                    {
                        await httpContext.ChallengeAsync(scheme);
                    }
                }
                else
                {
                    await httpContext.ChallengeAsync();
                }

                return;
            }
            else if (authorizeResult.Forbidden)
            {
                if (policy.AuthenticationSchemes.Count > 0)
                {
                    foreach (var scheme in policy.AuthenticationSchemes)
                    {
                        await httpContext.ForbidAsync(scheme);
                    }
                }
                else
                {
                    await httpContext.ForbidAsync();
                }

                return;
            }
        }
    }
}*/