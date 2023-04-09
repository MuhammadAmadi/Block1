import cv2

faceCascades = cv2.CascadeClassifier(cv2.data.haarcascades + ("haarcascade_frontalface_default.xml"))

# img = cv2.imread('test.jpg')
img = cv2.imread('faces.jpg')
imgGrey = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

faces = faceCascades.detectMultiScale(imgGrey)
#print(faces)
for (x, y, w, h) in faces:
    cv2.rectangle(img, (x,y),(x+w,y+h), (255,0,0), 1)


# img = cv2.resize(img, (500, 500))
# print(img.shape)
cv2.imshow('Posle', img)

cv2.waitKey(0)
