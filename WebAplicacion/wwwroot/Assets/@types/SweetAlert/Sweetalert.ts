
interface Imixin {
    toast?: boolean;
    didOpen?: (obj?: any) => void;
    backdrop?: string;
    customClass?: { confirmButton: string },
    position?: string;
    showConfirmButton?: boolean;
    timer?: number;
    icon?: "success" | "error" | "warning";
    timerProgressBar?: boolean;
    showCancelButton?: boolean;
    confirmButtonColor?: string;
    cancelButtonColor?: string;
    confirmButtonText?: string;
    title?: string;

}

interface ISwalPromiseReturnComfirm {
    isConfirmed:boolean

}

interface ISwal {
    mixin(obj?: Imixin):ISwal;
    fire(obj: { icon?: "success" | "error" | "warning", title?: string }):Promise<void>;
    fire(titulo?: string, Mensaje?: string, tipo?: "success" | "error" | "warning"): Promise<void>;
    fire(Mensaje?: string): Promise<void>;
    fire(obj: { title: string, icon?: "success" | "error" | "warning", showCancelButton: true, confirmButtonColor: string, cancelButtonColor: string, confirmButtonText: string, }): Promise<ISwalPromiseReturnComfirm>
    showLoading();
    stopTimer?: any;
    resumeTimer?: any;
    close(): void;
}

declare var Swal: ISwal;
