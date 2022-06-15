import numpy as np
import requests
import matplotlib.pyplot as plt
import matplotlib.image as mpimg
import sys
import datetime
from tensorflow import keras
from tensorflow.keras.models import Model
import tensorflow as tf
import pathlib
import os
import cv2
os.environ['TF_CPP_MIN_LOG_LEVEL'] = '1'

data_dir = pathlib.Path('Données')

image_count = len(list(data_dir.glob('*/*')))

#definir le nombre d'image envoyé ici 3 par 3
#redefinir la taille de l'image ici 200x200
batch_size = 3
img_height = 200
img_width = 200

#definir le nombre de classes ici 2 (pikachu et rondoudou)
#ici on a notre données d'entrainement qui contient 2 classes
train_data = tf.keras.preprocessing.image_dataset_from_directory(
  data_dir,
  validation_split=0.2,
  subset="training",
  seed=42,
  image_size=(img_height, img_width),
  batch_size=batch_size,
  )

val_data = tf.keras.preprocessing.image_dataset_from_directory(
  data_dir,
  validation_split=0.2,
  subset="validation",
  seed=42,
  image_size=(img_height, img_width),
  batch_size=batch_size)

class_names = val_data.class_names
print(class_names)



plt.figure(figsize=(10, 10))
for images, labels in train_data.take(1):
  for i in range(3):
    ax = plt.subplot(1, 3, i + 1)
    plt.imshow(images[i].numpy().astype("uint8"))
    plt.title(class_names[labels[i]])
    plt.axis("off")

