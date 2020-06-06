using System.Collections.Generic;

namespace UseMwBlazorTree.Models
{
    /// <summary>
    /// チームクラス
    /// </summary>
    public class Team
    {
        /// <summary>
        /// インデックス（並び順）を取得または設定します。
        /// </summary>
        public int Index { get; set; }
        
        /// <summary>
        /// 名称を取得または設定します。
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// 親チームを取得または設定します。
        /// </summary>
        public Team Parent { get; set; }
        
        /// <summary>
        /// 子チームリストを取得または設定します。
        /// </summary>
        public IList<Team> ChildItems { get; } = new List<Team>();

        /// <summary>
        /// 子チームを追加します。
        /// </summary>
        /// <param name="name">チーム名</param>
        /// <returns>追加したTeamオブジェクト</returns>
        public Team AddChild(string name)
        {
            Team team = new Team() { Name = name, Index = this.ChildItems.Count, Parent = this };
            this.ChildItems.Add(team);
            return team;
        }
    }
}
