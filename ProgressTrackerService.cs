public class ProgressTrackerService
{
    // Beginning stuff
    public bool LoansDone { get; set; } = false;
    public bool BeginningSafeBalancingDone { get; set; } = false;

    // Registers
    public bool RegistersCounted { get; set; } = false;
    public Dictionary<string, bool> RegisterStatus { get; set; } = new()
    {
        ["101"] = false,
        ["102"] = false,
        ["103"] = false,
        ["104"] = false,
        ["105"] = false,
        ["106"] = false,
        ["107"] = false,
        ["108"] = false,
        ["138mid"] = false,
        ["138close"] = false,
        ["140"] = false,
        ["140tickets"] = false,
        ["151"] = false,
        ["152"] = false,
        ["161"] = false,
        ["162"] = false,
        ["165"] = false,
    };

    // Deposits
    public bool DepositsDone { get; set; } = false;
    public bool CashDepositsDone { get; set; } = false;
    public bool CheckDepositsDone { get; set; } = false;

    // Reports
    public bool ReportsDone { get; set; } = false;
    public bool Post9PMReportsDone { get; set; } = false;
    public bool Post10PMReportsDone { get; set; } = false;
    public bool WesternUnionReportsDone { get; set; } = false;
    public bool SSCCReportsDone { get; set; } = false;
    public bool MoneyOrderReportsDone { get; set; } = false;
    public bool ITVMReportsDone { get; set; } = false;
    public bool EndOfNightReportsDone { get; set; } = false;

    // End of Night
    public bool EndOfNightTasksDone { get; set; } = false;
    public bool OvernightTillPlaced { get; set; } = false;
    public bool BackOfficeTillCounted { get; set; } = false;
    public bool EndOfNightWorkflowDone { get; set; } = false;
    public bool DepositBagsDropped { get; set; } = false;

    // Saturday
    public bool IsSaturday { get; set; }
    public bool SaturdayNightChecked { get; set; } = false;
    public bool SaturdayNightDone { get; set; } = false;

        // Initial Checklist
        public bool InitialChecklistDone { get; set; } = false;
        public bool NewEvelopesGathered { get; set; } = false;
        public bool OldEnvelopesReplaced { get; set; } = false;
        public bool WarePrepared { get; set; } = false;
        public bool WsmcPrepared { get; set; } = false;
        public bool WeeklyFoldersEmptied { get; set; } = false;
        public bool InitialMtmossccTotalsVerified { get; set; } = false;
        public bool InitialMailBagsPlaced { get; set; } = false;
        public bool PreviousWareShredded { get; set; } = false;

        // Reports (Saturday Night Flavor)
        public bool TaxExemptReportsDone { get; set; } = false;
        public bool SubdepartmentVouchersDone { get; set; } = false;

        // Saturday Night Closing Tasks
        public bool SaturdayNightClosingTasksDone { get; set; } = false;
        public bool CouponsCollected { get; set; } = false;
        public bool PurpleBagVerified { get; set; } = false;
        public bool GreenBagFinalized { get; set; } = false;

        
    public bool InstacartPhonesGrabbed { get; set; } = false;
    
    
}