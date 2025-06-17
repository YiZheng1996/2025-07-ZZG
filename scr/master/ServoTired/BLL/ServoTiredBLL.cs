using ServoTired.Model;
namespace ServoTired.BLL
{
    internal class ServoTiredBLL
    {
        public List<ServoTiredModelDto>? GetServoTiredTable(int type) => Helper.fsql?.Select<ServoTiredModel>()
            .ToList().Select(d => new ServoTiredModelDto
            {
                ID = d.ID,
                Speed = d.Speed,
                GearType = d.SGearType,
                StepNumber = d.StepNumber,
                ResidenceTime = d.ResidenceTime,
                StartPositionID = d.StartPositionID,
                StartPosition = Helper.fsql.Select<PointModel>().Where(a => a.ID == d.StartPositionID).First().GearPposition,
            })
            .Where(a => a.GearType == type)
            .OrderBy(a => a.StepNumber).ToList();

        public bool InsertTable(ServoTiredModel servo) => Helper.fsql?.Insert(servo).ExecuteAffrows() > 0;

        public bool UpdateTable(ServoTiredModel servo) => Helper.fsql?.Update<ServoTiredModel>()
            .Set(a => a.Speed, servo.Speed)
            .Set(a => a.ResidenceTime, servo.ResidenceTime)
            .Set(a => a.StartPositionID, servo.StartPositionID)
            .Where(a => a.StepNumber == servo.StepNumber && a.SGearType == servo.SGearType)
            .ExecuteAffrows() > 0;

        public bool ModifyOrAddTable(ServoTiredModel model)
        {
            var existing = Helper.fsql?.Select<ServoTiredModel>().Where(a => a.StepNumber == model.StepNumber && a.SGearType == model.SGearType).First();
            if (existing != null)
                return UpdateTable(model);
            else
                return InsertTable(model);
        }

        public bool DelTable(int id) => Helper.fsql?.Delete<ServoTiredModel>().Where(a => a.ID == id).ExecuteAffrows() > 0;

        public bool UpdateResidenceTime(ServoTiredModel servo) => Helper.fsql?.Update<ServoTiredModel>()
           .Set(a => a.ResidenceTime, servo.ResidenceTime)
           .Where(a => a.SGearType == servo.SGearType)
           .ExecuteAffrows() > 0;
    }
}
