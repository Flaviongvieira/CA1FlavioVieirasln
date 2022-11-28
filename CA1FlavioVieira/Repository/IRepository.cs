using CA1FlavioVieira.Models;

namespace CA1FlavioVieira.Repository
{
    public interface IRepository
    {

        // View list of all packages
        List<Package> DisplayPackages();

        // Create a new package
        public void AddPackage(Package package);

        // Update an existing package
        public void UpdatePackage(Package package); 

        // Display Package Info (PackageId, ShippingAddress, Volume, Density, ShippingCategory) 
        public ShippingInfo ShippingInfo(Package package);

        // Find Package for editing
        public Package GetPackage(int id);
    }
}
