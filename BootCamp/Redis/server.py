import redis
import random

with redis.Redis() as server:
    server.lpush("queue", random.randint(0,50))
    
