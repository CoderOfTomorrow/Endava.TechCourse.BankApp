﻿using AutoFixture.AutoNSubstitute;
using AutoFixture.NUnit3;
using EntityFrameworkCore.AutoFixture.Core;
using EntityFrameworkCore.AutoFixture.Sqlite;

namespace Endava.University.BankApp.Tests.Common
{
    public class ApplicationDataAttribute : InlineAutoDataAttribute
    {
        public ApplicationDataAttribute(params object[] arguments)
            : base(() => new Fixture()
                .Customize(new CompositeCustomization(
                    new AutoNSubstituteCustomization(),
                    new SqliteCustomization
                    {
                        AutoOpenConnection = true,
                        OmitDbSets = true,
                        OnCreate = OnCreateAction.EnsureCreated
                    })),
                    arguments)
        {
        }
    }
}