import socket
import os
import subprocess

def handle_get(uri):
    server_directory = os.path.dirname(os.path.realpath(__file__))
    
    try:
        with open(server_directory + uri) as f:
             return ''.join(f.readlines()), 200
    except FileNotFoundError:
        return 'Page not found', 404
    
def handle_request(request):
    lines = request.split('\n')
    print(request)
    request = lines[0].split()
    verb = request[0]
    uri = request[1]
    
    
    if verb == 'GET':
        return handle_get(uri)
    

if __name__ == '__main__':
    address = '127.0.0.1'
    port = 8080
    buffer_size = 1024

    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
    s.bind((address, port))
    s.listen(1)

    while True:
        conn, addr = s.accept()

        data = conn.recv(buffer_size)

        response, status = handle_request(data.decode())
        
        conn.send(response.encode())
        
        conn.close()