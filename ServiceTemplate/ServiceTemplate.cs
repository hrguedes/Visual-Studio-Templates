using Hrguedes.Atendor.Domain.Abstractions.Repositories;
using Hrguedes.Atendor.Domain.Abstractions;
using Hrguedes.Atendor.Domain.Abstractions.Services;
using Hrguedes.Atendor.Infra.Shared.Abstractions;

namespace $rootnamespace$;

public class $safeitemname$(I$fileinputname$Repository repository, IUnitOfWork unitOfWork) 
    : Service<$fileinputname$>(repository, unitOfWork), I$safeitemname$
{

}
