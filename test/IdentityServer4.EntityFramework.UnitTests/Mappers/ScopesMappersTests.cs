﻿using IdentityServer4.EntityFramework.Mappers;
using IdentityServer4.Models;
using Xunit;

namespace IdentityServer4.EntityFramework.UnitTests.Mappers
{
    public class ScopesMappersTests
    {
        [Fact]
        public void ScopeAutomapperConfigurationIsValid()
        {
            var entity = new Entities.Scope();
            var mappedModel = entity.ToModel();

            var model = new Scope();
            var mappedEntity = model.ToEntity();

            Assert.NotNull(mappedModel);
            Assert.NotNull(mappedEntity);
            ScopeMappers.Mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}