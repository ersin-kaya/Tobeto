import React from 'react'
import { ErrorMessage, Field } from "formik";

type Props = {
    label: string;
    name: string;
    // type opsiyonel olsun, 2 yol var
    type?: string; // ilk syntax
    // type: string | undefined;    // ikinci syntax !!(ilk syntax'ta type?'ın üzerine gelince " string | undefined " göreceksin) !!Ancak fazla doğrudan böyle yazarsak type'ı belirtmek gerekir bu yüzden pek sık kullanılmaz

    placeholder?: string;
    className?: string;
};

const FormikInput = (props: Props) => {
    return (
        <div className="mb-3">
            <label className="form-label">{props.label}</label>
            <Field
                name={props.name}
                type={props.type || "text"}
                placeholder={props.placeholder}
                className={`form-control ${props.className}` || "form-control"}
            />
            <ErrorMessage name={props.name}>
                {(message) => <span className="text-danger">{message}</span>}
            </ErrorMessage>
        </div>
    );
};

export default FormikInput