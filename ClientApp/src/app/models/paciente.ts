import { Estado } from './estado';
export class Paciente {
    id: string;
    nombre: string;
    apellido1: string;
    apellido2: string;
    provincia: string;
    canton: string;
    distrito: string;
    otros: string;
    correo: string;
    fechaNacimiento: Date;
    tipoSangre: string;
    estadoId: number;
}