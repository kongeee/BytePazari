using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Concrete {
    public class UserOperationClaims:IEntity {

        [Key]
        public int UserOperationClaimId { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
