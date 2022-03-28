
namespace CSharpMethod
{
    class Group
    {
        public string GroupName;
        public int MaxStuCount;
        public Group(string groupName,int maxCount)
        {
            GroupName = groupName;
        }
        public string Info()
        {
            return $"Group : {GroupName}, count : {MaxStuCount}";
        }
    }
}
