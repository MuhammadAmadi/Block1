import cv2

faceCascades = cv2.CascadeClassifier(cv2.data.haarcascades + ("haarcascade_frontalface_default.xml"))

cap = cv2.VideoCapture('videotest.mp4')


while True:
    _, frame = cap.read()
    capGray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    faces = faceCascades.detectMultiScale(capGray)
    
    if cv2.waitKey(1) & 0xff == ord('q'):
        break

    for i in faces:
        cv2.rectangle(frame, i, (255, 0, 0), 1)

    cv2.imshow('camera', frame)

