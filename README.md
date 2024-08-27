# ImageUploaderFormsApp
Technical Challenge 2 for Toppan Security
------------------------------------------

ImageUploaderApp contains the code for the Windows Forms App which is the client-side app.

ImageWebApp contains the code for the UploadController API which listens for HTTP POST requests and also the index.html for the web page that displays the uploaded image.

-----------------------------------------
How to run

Open BOTH solutions ImageUploaderApp.sln, ImageWebApp.sln and run them.
![ui-2](https://github.com/user-attachments/assets/f1af86cf-e125-4c47-b9ba-7037fe31b9a4)

-----------------------------------------

1) Browse for an image. It will show up in the UI as confirmation.
2) Click upload to send a POST request to the image upload controller which saves the image to a folder.
3) The webpage will read the image(s) in the folder. As of now, only one image is saved to a fixed file name so only one image will be shown at all times.

Client-side App
![UI-1](https://github.com/user-attachments/assets/2e8cb70a-6e41-450a-a98f-2fdebfe73b1d)

----------------------------------------

Web Page
![image](https://github.com/user-attachments/assets/f4ea8522-801c-4f15-bddf-462f8e67b9ae)

