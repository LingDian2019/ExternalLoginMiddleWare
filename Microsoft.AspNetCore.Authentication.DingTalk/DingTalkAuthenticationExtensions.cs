using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.AspNetCore.Authentication.DingTalk
{
    public static class DingTalkExtensions
    {
        public static AuthenticationBuilder AddDingTalk(this AuthenticationBuilder builder)
            => builder.AddDingTalk(DingTalkAuthenticationDefaults.AuthenticationScheme, _ => { });

        //这里是入口
        public static AuthenticationBuilder AddDingTalk(this AuthenticationBuilder builder, Action<DingTalkAuthenticationOptions> configureOptions)
            => builder.AddDingTalk(DingTalkAuthenticationDefaults.AuthenticationScheme, configureOptions);

        public static AuthenticationBuilder AddDingTalk(this AuthenticationBuilder builder, string authenticationScheme, Action<DingTalkAuthenticationOptions> configureOptions)
            => builder.AddDingTalk(authenticationScheme, DingTalkAuthenticationDefaults.DisplayName, configureOptions);

        public static AuthenticationBuilder AddDingTalk(this AuthenticationBuilder builder, string authenticationScheme, string displayName, Action<DingTalkAuthenticationOptions> configureOptions)
            => builder.AddOAuth<DingTalkAuthenticationOptions, DingTalkAuthenticationHandler>(authenticationScheme, displayName, configureOptions);
    }
}
