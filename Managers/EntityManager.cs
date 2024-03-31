
namespace JurassicDash
{
    internal class EntityManager
    {
        private readonly List<IGameEntity> _entities;

        public EntityManager()
        {
            _entities = new List<IGameEntity>();
        }

        public void AddEntity(IGameEntity entity)
        {
            _entities.Add(entity);
        }

        public void RemoveEntity(IGameEntity entity)
        {
            _entities.Remove(entity);
        }

        public void Update(GameTime gameTime)
        {
            foreach (IGameEntity entity in _entities)
            {
                entity.Update(gameTime);
            }
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            foreach (IGameEntity entity in _entities)
            {
                entity.Draw(spriteBatch, gameTime);
            }
        }
    }
}
