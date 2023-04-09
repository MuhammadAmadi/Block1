import redis

with redis.Redis() as client:
    value = client.brpop("queue")

print(int(value[1])) 