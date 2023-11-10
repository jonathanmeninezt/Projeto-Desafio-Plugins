using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;

namespace MeuProjetoInicial {
    internal class CrmServiceClient {
        private string connectionStringCRM;

        public CrmServiceClient(string connectionStringCRM) {
            this.connectionStringCRM = connectionStringCRM;
        }

        internal Guid Create(Entity newEntity) {
            throw new NotImplementedException();
        }

        internal EntityCollection RetrieveMultiple(FetchExpression fetchExpression) {
            throw new NotImplementedException();
        }
    }
}