# lds_bonsai
A bonsai environment for online linear dynamical systems

## How to build

1. Bootstrap the Bonsai environment:

```PS
bonsai\Setup.ps1
```

2. Boostrap the Python environment:

```PS
python -m venv pyenv
pyenv\Scripts\activate
pip install -r modules\lds_python\requirements.txt
```

3. Run Bonsai:

```PS
bonsai\Bonsai.exe workflows\onlineLds.bonsai
```