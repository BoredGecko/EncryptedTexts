# CryptedFriends - a program for encrypting messages.

## Idea: Communicating with friends with encrypted messages.

## Language: C#.

## Operating instructions:

Select the operating mode of the program (encryption [E/e] or decryption [D/d] of the message). 

### Encryption: Enter unencrypted text. The encrypted text and the encryption key to it will be given below. 
You will need to tell the encryption key to your interlocutor so that he can decrypt the message.

### Decryption: Enter the encrypted text and the encryption key. The decrypted text will be displayed below.

## Working principle:
Encryption is performed by the shift method.

### Encryption:
1. Enter the text for encryption.
2. The text is divided into characters.
3. Each character is assigned an encoded number.
4. An encryption key is generated.
5. The character number in the encoding is shifted taking into account the encryption key.
6. The symbol is changed taking into account its new number in the encoding.
7. The encrypted text and the encryption key are output.

### Decryption:
1. Enter the encrypted text and the encryption key.
2. The text is divided into characters.
3. Each character is assigned an encoded number.
4. The number of the character in the encoding is changed taking into account the encryption key.
5. The symbol is changed taking into account its new number in the encoding.
6. The decrypted text is displayed.

____
Please [let me know](https://github.com/EvilVolfy/Simple-Encryptor-Decryptor/issues/new) if you find a bug.
____


# CryptedFriends - программа для шифровки сообщений.

## Идея: общение с друзьями зашифрованными сообщениями.

## Язык: C#.

## Инструкция по эксплуатации:
 
Выберите режим работы программы (шифровка [E/e] или расшифровка [D/d] сообщения). 

### Шифровка: Введите незашифрованный текст. Ниже будет выдан зашифрованный текст и ключ шифрования к нему. 
Вы должны будете сообщить ключ шифрования своему собеседнику, для того, чтобы он смог расшифровать сообщение.

### Расшифровка: Введите зашифрованный текст и ключ шифрования. Ниже будет выведен расшифрованный текст.

## Принцип работы:
Шифрование происходит методом сдвига.

### Шифровка:
1. Вводится текст для шифрования.
2. Текст делится на символы.
3. Каждому символу присваивается номер в кодировке.
4. Генерируется ключ шифрования.
5. Номер символа в кодировке сдвигается с учетом ключа шифрования.
6. Символ изменяется с учетом его нового номера в кодировке.
7. Выводится зашифрованный текст и ключ шифрования.

### Расшифровка:
1. Вводится зашифрованный текст и ключ шифрования.
2. Текст делится на символы.
3. Каждому символу присваивается номер в кодировке.
4. Номер символа в кодировке изменяется с учетом ключа шифрования.
5. Символ изменяется с учетом его нового номера в кодировке.
6. Выводится расшифрованный текст.
 ____
 Пожалуйста, [сообщите мне](https://github.com/EvilVolfy/Simple-Encryptor-Decryptor/issues/new), если нашли баг.
