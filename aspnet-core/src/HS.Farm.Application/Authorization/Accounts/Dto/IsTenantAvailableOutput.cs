namespace HS.Farm.Authorization.Accounts.Dto
{
    public class IsTenantAvailableOutput
    {
        public TenantAvailabilityState State { get; set; }

        public virtual int? TenantId { get; set; }

        public IsTenantAvailableOutput()
        {
        }

        public IsTenantAvailableOutput(TenantAvailabilityState state, int? tenantId = null)
        {
            State = state;
            TenantId = tenantId;
        }
    }
}
