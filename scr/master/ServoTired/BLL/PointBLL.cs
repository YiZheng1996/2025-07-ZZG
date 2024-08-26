using ServoTired.Model;

namespace ServoTired.BLL
{
    internal class PointBLL
    {
        public List<PointModel>? GetPoints() => Helper.fsql?.Select<PointModel>().ToList();

        public List<PointModel>? GetPoints(int? type) => Helper.fsql?.Select<PointModel>()
            .Where(t => t.GearType == type).ToList();
    }
}
