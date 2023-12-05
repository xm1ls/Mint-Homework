namespace Chamomile_UI.States
{
    public class ChoosedTableState
    {
        public event Action? TableChoosed;

        public string? TableName { get; set; } = null;

        public void ChooseTable(string? tableName)
        {
            TableName = tableName;
            TableChoosed?.Invoke();
        }
    }
}
