# arttsabor-backend
Backend project for Artt Sabor, my mom snack business

Build
´´´
docker build -t arttsabor-back -f Dockerfile .
´´´
Run
´´´
docker run --network artt_sabor -it --rm -p 25100:25100 --name artt_sabor_dotnet arttsabor-back
´´´
