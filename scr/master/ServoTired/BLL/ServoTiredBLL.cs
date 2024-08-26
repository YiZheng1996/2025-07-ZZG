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
                StopPositionID = d.StopPositionID,
                StartPosition = Helper.fsql.Select<PointModel>().Where(a => a.ID == d.StartPositionID).First().GearPposition,
                StopPosition = Helper.fsql.Select<PointModel>().Where(p => p.ID == d.StopPositionID).First().GearPposition,
            }).Where(a => a.GearType == type).ToList();

        public bool InsertTable(ServoTiredModel servo) => Helper.fsql?.Insert(servo).ExecuteAffrows() > 0;

        public bool UpdateTable(ServoTiredModel servo) => Helper.fsql?.Update<ServoTiredModel>()
            .Set(a => a.Speed, servo.Speed)
            .Set(a => a.ResidenceTime, servo.ResidenceTime)
            .Set(a => a.StartPositionID, servo.StartPositionID)
            .Set(a => a.StopPositionID, servo.StopPositionID)
            .Where(a => a.StepNumber == servo.StepNumber)
            .ExecuteAffrows() > 0;

        public bool ModifyOrAddTable(ServoTiredModel model)
        {
            var existing = Helper.fsql?.Select<ServoTiredModel>().Where(a => a.StepNumber == model.StepNumber && a.SGearType == model.SGearType).First();
            if (existing != null)
                return UpdateTable(model);
            else
                return InsertTable(model);
        }

        public bool DelTable(int id) => Helper.fsql?.Delete<ServoTiredModel>().Where(a => a.StepNumber == id).ExecuteAffrows() > 0;
    }
}
