namespace animales
{
    public abstract class animal
    {
        //los metodos abstractos no tienen implementacion y estan dentro de calses abstractas
        //las clases abstractas no se pueden instanciar
        //estas obligado a dar una implementacion en las clases hijas

        //los metodos virtuales si tienen implementacion
        //no estas obligado a sobreescribirlo con override e las clases hijas
        //las clases que no sean abstractas si se pueden instanciar

        public abstract void Saludar();
    }
}