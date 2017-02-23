import pyperclip

LETTERS = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'

def main():
    myMessage = """Tuy nhiên, tại cuộc báo hôm nay, ông Ren Guoqiang, phát ngôn viên Bộ Quốc phòngTrung Quốc nói: “Về thông tin các bạn đề cập đến là Quân giải phóng Nhân dân Trung Quốc tăng cường lực lượng tại biên giới Trung Quốc -Triều Tiên, thông tin này là hoàn toàn vô căn cứ và bịa đặt”. Tuy nhiên, quan chức này không nêu rõ thêm cho khẳng định của mình."""
    myKey = 'học mật mã thật là vui'
    myMode = 'encrypt'

    if myMode == 'encrypt':
        translated = encryptMessage(myKey, myMessage)
    elif myMode == 'decrypt':
        translated = decryptMessage(myKey, myMessage)

    print('%sed message:' % (myMode.title()))
    print(translated)

def encryptMessage(key, message):
    return translateMessage(key, message, 'encrypt')

def decryptMessage(key, message):
    return translateMessage(key, message, 'decrypt')

def translateMessage(key, message, mode):
    translated = [] 

    keyIndex = 0
    key = key.upper()

    for symbol in message:
        num = LETTERS.find(symbol.upper())
        if num != -1: 
            if mode == 'encrypt':
                num += LETTERS.find(key[keyIndex]) 
            elif mode == 'decrypt':
                num -= LETTERS.find(key[keyIndex]) 

            num %= len(LETTERS)
            if symbol.isupper():
                translated.append(LETTERS[num])
            elif symbol.islower():
                translated.append(LETTERS[num].lower())

            keyIndex += 1 
            if keyIndex == len(key):
                keyIndex = 0
        else:
            translated.append(symbol)

    return ''.join(translated)

if __name__ == '__main__':
    main()
