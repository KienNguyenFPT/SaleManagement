namespace Assignment_02_Solution
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoginForm lf = new LoginForm(); 
            MemberManagement mb = new MemberManagement();   
            CategoryManagement cm = new CategoryManagement(); 
            ProductManagement pm = new ProductManagement();
            OrderManagement om  = new OrderManagement();
            Report rp = new Report();   
            
            lf.StartPosition = FormStartPosition.CenterScreen;  
            mb.StartPosition = FormStartPosition.CenterScreen;  
            cm.StartPosition = FormStartPosition.CenterScreen;
            pm.StartPosition = FormStartPosition.CenterScreen;
            om.StartPosition = FormStartPosition.CenterScreen;  
            rp.StartPosition = FormStartPosition.CenterScreen;  
            Application.Run(lf);
        }
    }
}