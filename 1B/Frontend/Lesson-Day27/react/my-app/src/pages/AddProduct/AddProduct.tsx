import { Form, Formik } from 'formik'
import React from 'react'
import { number, object, string } from 'yup'
import FormikInput from '../../components/FormikInput/FormikInput'
import { passwordValidator } from "../../utils/customValidations";

type Props = {}

const AddProduct = (props: Props) => {
    const initialValues = {
        title: "",
        description: "",
        price: 0,
        stock: 0,
    }

    // Backend validasyonu güvenlik,
    // Frontend validasyonu hem UX hem de performans için yapılır
    // Örn. kullanıcının hatalı veri girişi yaptığında bunu backend'den yanıt geldiğinde öğrenecek, yani backend'e hatalı veriyle istek atmış olacak bir kere.. 
    const validationSchema = object({
        title: string()
            .required("Başlık alanı zorunludur.")
            .min(3, "Başlık alanı en az 3 karakter olmalıdır.")
            .max(50)
            .test(
                "my-custom-rule",
                "En az 1 büyük, 1 küçük harf ve 1 rakam içermelidir.",
                passwordValidator,
                // (value, context) => {
                //     console.log(value)
                //     console.log(context)
                //     console.log(context.from?.at(0)?.value) // ile oluşturduğumuz objenin değerlerine ulaşabiliyoruz (birbirine göre validate edilecek alanlar için kullanılabilir örn. bitiş tarihi başlangıç tarihine göre daha ileri bir tarih olacaksa..)

                //     // son olarak return
                //     return false // false dersen onaylamaz..
                // }
            ),
        description: string().required().min(5).max(300),
        price: number().required().min(0),
        stock: number()
            .required()
            .positive()
            .integer(),
    });

    return (
        <div className="container mt-5">
            <Formik
                // isInitialValid={true}
                initialValues={initialValues}
                onSubmit={(values) => { console.log(values) }}
                validationSchema={validationSchema}
            >
                {/* handler diyince aklımıza func. gelecek */}

                <Form>
                    <FormikInput
                        name="title"
                        label="Ürün Adı"
                        placeholder="Ürün adı giriniz..."
                    />
                    <FormikInput name="description" label="Ürün Açıklaması" />
                    <FormikInput name="price" label="Ürün Fiyatı"
                        className="text-success" />
                    <FormikInput name="stock" label="Ürün Stok"
                        className="text-success" />
                    <button type="submit" className="btn btn-primary">
                        Kaydet
                    </button>
                </Form>
            </Formik>
        </div>
    )
}

export default AddProduct