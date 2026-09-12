using UnityEngine;

namespace UnityStudy.DesignPatterns.DirtyFlag
{
    public class GameSectors : MonoBehaviour
    {
        public Player player;
        public Sector[] sectors;

        private void Update()
        {
            foreach (Sector sector in sectors)
            {
                bool isPlayerClose = sector.IsPlayerClose(player.transform.position);

                // Check if the sector's state needs to change
                if(isPlayerClose != sector.IsLoaded)
                {
                    sector.MarkDirty();
                }

                // Update the sector based on its dirty flag
                if(sector.IsDirty)
                {
                    if(isPlayerClose)
                    {
                        sector.LoadContent();
                    } else
                    {
                        sector.UnloadContent();
                    }

                    // Reset the dirty flag
                    sector.Clean();
                }
            }
        }
    }
}
